<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveFormRemarkRequest extends Model
{
    /**
     * @description 应用ID
     *
     * @var string
     */
    public $appType;

    /**
     * @description 将评论内容通过钉钉发给指定用户, 逗号分隔
     *
     * @var string
     */
    public $atUserId;

    /**
     * @description 评论内容
     *
     * @var string
     */
    public $content;

    /**
     * @description 实例ID
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @description 语言
     *
     * @var string
     */
    public $language;

    /**
     * @description 对评论进行回复
     *
     * @var int
     */
    public $replyId;

    /**
     * @description 应用秘钥
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 评论人钉钉的userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'        => 'appType',
        'atUserId'       => 'atUserId',
        'content'        => 'content',
        'formInstanceId' => 'formInstanceId',
        'language'       => 'language',
        'replyId'        => 'replyId',
        'systemToken'    => 'systemToken',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->atUserId) {
            $res['atUserId'] = $this->atUserId;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->replyId) {
            $res['replyId'] = $this->replyId;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveFormRemarkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['atUserId'])) {
            $model->atUserId = $map['atUserId'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['replyId'])) {
            $model->replyId = $map['replyId'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
