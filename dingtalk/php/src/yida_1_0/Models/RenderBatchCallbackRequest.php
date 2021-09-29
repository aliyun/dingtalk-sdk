<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class RenderBatchCallbackRequest extends Model
{
    /**
     * @description oss文件链接
     *
     * @var string
     */
    public $ossUrl;

    /**
     * @description 组织id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 文件大小
     *
     * @var int
     */
    public $fileSize;

    /**
     * @description appType
     *
     * @var string
     */
    public $appType;

    /**
     * @description systemToken
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 名称空间
     *
     * @var string
     */
    public $namespace;

    /**
     * @description 时间区域
     *
     * @var string
     */
    public $timeZone;

    /**
     * @description language
     *
     * @var string
     */
    public $language;

    /**
     * @description 源
     *
     * @var string
     */
    public $source;

    /**
     * @description 流水号
     *
     * @var string
     */
    public $sequenceId;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 状态
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'ossUrl'      => 'ossUrl',
        'corpId'      => 'corpId',
        'fileSize'    => 'fileSize',
        'appType'     => 'appType',
        'systemToken' => 'systemToken',
        'namespace'   => 'namespace',
        'timeZone'    => 'timeZone',
        'language'    => 'language',
        'source'      => 'source',
        'sequenceId'  => 'sequenceId',
        'userId'      => 'userId',
        'status'      => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ossUrl) {
            $res['ossUrl'] = $this->ossUrl;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->namespace) {
            $res['namespace'] = $this->namespace;
        }
        if (null !== $this->timeZone) {
            $res['timeZone'] = $this->timeZone;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->sequenceId) {
            $res['sequenceId'] = $this->sequenceId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RenderBatchCallbackRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ossUrl'])) {
            $model->ossUrl = $map['ossUrl'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['namespace'])) {
            $model->namespace = $map['namespace'];
        }
        if (isset($map['timeZone'])) {
            $model->timeZone = $map['timeZone'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['sequenceId'])) {
            $model->sequenceId = $map['sequenceId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
