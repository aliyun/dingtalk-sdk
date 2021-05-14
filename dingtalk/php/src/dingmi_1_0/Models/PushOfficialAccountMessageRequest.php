<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushOfficialAccountMessageRequest extends Model
{
    /**
     * @description 企业corpId
     *
     * @var string
     */
    public $dingCorpId;

    /**
     * @description 用户id(在服务窗对应虚拟企业中的用户id)
     *
     * @var string
     */
    public $userId;

    /**
     * @description 消息类型
     *
     * @var string
     */
    public $msgKey;

    /**
     * @description 消息模板替换参数
     *
     * @var string
     */
    public $msgParam;
    protected $_name = [
        'dingCorpId' => 'dingCorpId',
        'userId'     => 'userId',
        'msgKey'     => 'msgKey',
        'msgParam'   => 'msgParam',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->msgKey) {
            $res['msgKey'] = $this->msgKey;
        }
        if (null !== $this->msgParam) {
            $res['msgParam'] = $this->msgParam;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushOfficialAccountMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['msgKey'])) {
            $model->msgKey = $map['msgKey'];
        }
        if (isset($map['msgParam'])) {
            $model->msgParam = $map['msgParam'];
        }

        return $model;
    }
}
