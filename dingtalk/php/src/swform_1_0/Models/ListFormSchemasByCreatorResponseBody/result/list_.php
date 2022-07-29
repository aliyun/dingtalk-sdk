<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormSchemasByCreatorResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormSchemasByCreatorResponseBody\result\list_\setting;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 创建人。
     *
     * @var string
     */
    public $creator;

    /**
     * @description 填表code，用此code可调接口获取填表列表。
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 填表提示。
     *
     * @var string
     */
    public $memo;

    /**
     * @description 填表名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 填表设置。
     *
     * @var setting
     */
    public $setting;
    protected $_name = [
        'creator'  => 'creator',
        'formCode' => 'formCode',
        'memo'     => 'memo',
        'name'     => 'name',
        'setting'  => 'setting',
    ];

    public function validate()
    {
    }

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
