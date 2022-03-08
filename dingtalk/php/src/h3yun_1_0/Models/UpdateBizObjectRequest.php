<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateBizObjectRequest extends Model
{
    /**
     * @description 业务数据id
     *
     * @var string
     */
    public $bizObjectId;

    /**
     * @description 待修改的json格式业务数据
     *
     * @var string
     */
    public $bizObjectJson;

    /**
     * @description 表单编码
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'bizObjectId'   => 'bizObjectId',
        'bizObjectJson' => 'bizObjectJson',
        'schemaCode'    => 'schemaCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizObjectId) {
            $res['bizObjectId'] = $this->bizObjectId;
        }
        if (null !== $this->bizObjectJson) {
            $res['bizObjectJson'] = $this->bizObjectJson;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateBizObjectRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizObjectId'])) {
            $model->bizObjectId = $map['bizObjectId'];
        }
        if (isset($map['bizObjectJson'])) {
            $model->bizObjectJson = $map['bizObjectJson'];
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }

        return $model;
    }
}
