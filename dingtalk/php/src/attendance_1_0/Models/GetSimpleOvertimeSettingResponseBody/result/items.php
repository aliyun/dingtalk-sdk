<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetSimpleOvertimeSettingResponseBody\result;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @description 加班规则id
     *
     * @var int
     */
    public $id;

    /**
     * @description 加班规则名称
     *
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $settingId;
    protected $_name = [
        'id'        => 'id',
        'name'      => 'name',
        'settingId' => 'settingId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->settingId) {
            $res['settingId'] = $this->settingId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['settingId'])) {
            $model->settingId = $map['settingId'];
        }

        return $model;
    }
}
