<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormSchemasByCreatorResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormSchemasByCreatorResponseBody\result\list_\setting;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example user123
     *
     * @var string
     */
    public $creator;

    /**
     * @example PROC-E5BD2166-B6F4-xxxx
     *
     * @var string
     */
    public $formCode;

    /**
     * @example 请大家仔细填写，谢谢合作
     *
     * @var string
     */
    public $memo;

    /**
     * @example 智能填表测试
     *
     * @var string
     */
    public $name;

    /**
     * @var setting
     */
    public $setting;
    protected $_name = [
        'creator' => 'creator',
        'formCode' => 'formCode',
        'memo' => 'memo',
        'name' => 'name',
        'setting' => 'setting',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->setting) {
            $res['setting'] = null !== $this->setting ? $this->setting->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['setting'])) {
            $model->setting = setting::fromMap($map['setting']);
        }

        return $model;
    }
}
