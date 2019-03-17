(function () {
    $(function () {
        var _courseService = abp.services.app.course;
        var _$modal = $('#CourseCreateModal');
        var _$form = _$modal.find('form');

        //添加课程
        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();
            if (!_$form.valid()) {
                return;
            }
            var courseEditDto = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js

            abp.ui.setBusy(_$modal);
            _courseService.createOrUpdateCourse({ courseEditDto }).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new course!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        $('#CourseCreateModal').on('hide.bs.modal',
            function () {
                // 执行一些动作...


                _$form[0].reset();
            });

        
    });
})();