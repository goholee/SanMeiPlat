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
                location.reload(true); //reload page to see new course!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        $('#CourseTypeCreateModal').on('hide.bs.modal',
            function () {
                // 执行一些动作...


                _$form[0].reset();
            });

        
    });
})();