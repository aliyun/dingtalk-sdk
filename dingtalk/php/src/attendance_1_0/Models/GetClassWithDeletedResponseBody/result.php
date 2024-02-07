<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClassWithDeletedResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClassWithDeletedResponseBody\result\classSetting;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClassWithDeletedResponseBody\result\sections;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $classId;

    /**
     * @var classSetting
     */
    public $classSetting;

    /**
     * @example ding1234
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 夜班
     *
     * @var string
     */
    public $name;

    /**
     * @var sections[]
     */
    public $sections;

    /**
     * @var int[]
     */
    public $workDays;
    protected $_name = [
        'classId'      => 'classId',
        'classSetting' => 'classSetting',
        'corpId'       => 'corpId',
        'name'         => 'name',
        'sections'     => 'sections',
        'workDays'     => 'workDays',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->classSetting) {
            $res['classSetting'] = null !== $this->classSetting ? $this->classSetting->toMap() : null;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->sections) {
            $res['sections'] = [];
            if (null !== $this->sections && \is_array($this->sections)) {
                $n = 0;
                foreach ($this->sections as $item) {
                    $res['sections'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->workDays) {
            $res['workDays'] = $this->workDays;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['classSetting'])) {
            $model->classSetting = classSetting::fromMap($map['classSetting']);
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['sections'])) {
            if (!empty($map['sections'])) {
                $model->sections = [];
                $n               = 0;
                foreach ($map['sections'] as $item) {
                    $model->sections[$n++] = null !== $item ? sections::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['workDays'])) {
            if (!empty($map['workDays'])) {
                $model->workDays = $map['workDays'];
            }
        }

        return $model;
    }
}
