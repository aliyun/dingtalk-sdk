<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveFormRemarkRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example APP_PBKT0MFBEBTDO8T7SLVP
     *
     * @var string
     */
    public $appType;

    /**
     * @example 多个工号,用英文逗号分隔
     *
     * @var string
     */
    public $atUserId;

    /**
     * @description This parameter is required.
     *
     * @example 未知
     *
     * @var string
     */
    public $content;

    /**
     * @example vpc,sgp_vpc
     *
     * @var string
     */
    public $env;

    /**
     * @description This parameter is required.
     *
     * @example 33f6d221-17f8-42b7-836a-682b95a046c2
     *
     * @var string
     */
    public $formInstanceId;

    /**
     * @example FORM-EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ3
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @example 12
     *
     * @var int
     */
    public $replyId;

    /**
     * @description This parameter is required.
     *
     * @example hexxxx
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description This parameter is required.
     *
     * @example 未知
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType' => 'appType',
        'atUserId' => 'atUserId',
        'content' => 'content',
        'env' => 'env',
        'formInstanceId' => 'formInstanceId',
        'formUuid' => 'formUuid',
        'language' => 'language',
        'replyId' => 'replyId',
        'systemToken' => 'systemToken',
        'userId' => 'userId',
    ];

    public function validate() {}

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
        if (null !== $this->env) {
            $res['env'] = $this->env;
        }
        if (null !== $this->formInstanceId) {
            $res['formInstanceId'] = $this->formInstanceId;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
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
        if (isset($map['env'])) {
            $model->env = $map['env'];
        }
        if (isset($map['formInstanceId'])) {
            $model->formInstanceId = $map['formInstanceId'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
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
