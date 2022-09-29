<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\InstallAppResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 套件业务类型
     *
     * @var string
     */
    public $bizType;

    /**
     * @description 模版名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 模版processcode
     *
     * @var string
     */
    public $processCode;
    protected $_name = [
        'bizType'     => 'bizType',
        'name'        => 'name',
        'processCode' => 'processCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
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
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }

        return $model;
    }
}
