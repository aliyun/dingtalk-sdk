<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateBizObjectRequest extends Model
{
    /**
     * @description json格式的业务数据
     *
     * @var string
     */
    public $bizObjectJson;

    /**
     * @description 是否是草稿数据。true=草稿数据，false=生效数据
     *
     * @var bool
     */
    public $isDraft;

    /**
     * @description 操作用户id。可从“获取用户信息”API获取
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 表单编码
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'bizObjectJson' => 'bizObjectJson',
        'isDraft'       => 'isDraft',
        'opUserId'      => 'opUserId',
        'schemaCode'    => 'schemaCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizObjectJson) {
            $res['bizObjectJson'] = $this->bizObjectJson;
        }
        if (null !== $this->isDraft) {
            $res['isDraft'] = $this->isDraft;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateBizObjectRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizObjectJson'])) {
            $model->bizObjectJson = $map['bizObjectJson'];
        }
        if (isset($map['isDraft'])) {
            $model->isDraft = $map['isDraft'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }

        return $model;
    }
}
