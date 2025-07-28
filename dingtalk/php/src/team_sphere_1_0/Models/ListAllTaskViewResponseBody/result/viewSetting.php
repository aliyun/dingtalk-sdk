<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\ListAllTaskViewResponseBody\result;

use AlibabaCloud\Tea\Model;

class viewSetting extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $showDoneTask;

    /**
     * @example true
     *
     * @var bool
     */
    public $showSubTask;
    protected $_name = [
        'showDoneTask' => 'showDoneTask',
        'showSubTask' => 'showSubTask',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->showDoneTask) {
            $res['showDoneTask'] = $this->showDoneTask;
        }
        if (null !== $this->showSubTask) {
            $res['showSubTask'] = $this->showSubTask;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return viewSetting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['showDoneTask'])) {
            $model->showDoneTask = $map['showDoneTask'];
        }
        if (isset($map['showSubTask'])) {
            $model->showSubTask = $map['showSubTask'];
        }

        return $model;
    }
}
