(function () {
    $(function () {
        var _courseTypeService = abp.services.app.courseType;
        var _$modal = $('#CourseTypeCreateModal');
        var _$form = _$modal.find('form');

        //添加课程
        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();
            if (!_$form.valid()) {
                return;
            }
            var courseTypeEditDto = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js

            abp.ui.setBusy(_$modal);
            _courseTypeService.createOrUpdateCourseType({ courseTypeEditDto }).done(function () {
                _$modal.modal('hide');
                //location.reload(true); //reload page to see new course!
                refreshList();
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        $('#CourseTypeCreateModal').on('hide.bs.modal',
            function () {
                // 执行一些动作...


                _$form[0].reset();
            });

        //刷新
        $("#RefreshButton").click(function () {
            refreshList();
        });
        function refreshList() {
            location.reload();
        }

        //删除
        $(".delete-courseType").click(function () {
            var courseTypeId = $(this).attr("data-courseType-id");
            var courseTypeName = $(this).attr("data-courseType-name");
            deleteCourseType(courseTypeId, courseTypeName);
        });
        function deleteCourseType(id,name) {
            abp.message.confirm("是否确认删除课程类型：" + name,
                function (isConfirmed) {
                    if (isConfirmed) {
                        _courseTypeService.deleteCourseType({ id }).done(function () {
                            refreshList();
                        });
                    }
            });
        }

        //编辑

        $(".edit-courseType").click(function (e) {
            e.preventDefault();
            var courseTypeId = $(this).attr("data-courseType-id");
            _courseTypeService.getCourseTypeForEdit({ id:courseTypeId }).done(function (data) {
                $("input[name=Id]").val(data.courseType.id);
                $("input[name=CourseTypeName]").val(data.courseType.courseTypeName).parent().addClass("focused");
            });
        });

    });
})();