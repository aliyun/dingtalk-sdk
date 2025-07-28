<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class RenderBatchCallbackRequest extends Model
{
    /**
     * @var string
     */
    public $appType;

    /**
     * @example ding123
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 123789
     *
     * @var int
     */
    public $fileSize;

    /**
     * @var string
     */
    public $language;

    /**
     * @example dingtalk
     *
     * @var string
     */
    public $namespace;

    /**
     * @example https://oss/com/a/b.pdf
     *
     * @var string
     */
    public $ossUrl;

    /**
     * @example seq-xxx
     *
     * @var string
     */
    public $sequenceId;

    /**
     * @example 宜搭
     *
     * @var string
     */
    public $source;

    /**
     * @example running
     *
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $systemToken;

    /**
     * @example GMT
     *
     * @var string
     */
    public $timeZone;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType' => 'appType',
        'corpId' => 'corpId',
        'fileSize' => 'fileSize',
        'language' => 'language',
        'namespace' => 'namespace',
        'ossUrl' => 'ossUrl',
        'sequenceId' => 'sequenceId',
        'source' => 'source',
        'status' => 'status',
        'systemToken' => 'systemToken',
        'timeZone' => 'timeZone',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->namespace) {
            $res['namespace'] = $this->namespace;
        }
        if (null !== $this->ossUrl) {
            $res['ossUrl'] = $this->ossUrl;
        }
        if (null !== $this->sequenceId) {
            $res['sequenceId'] = $this->sequenceId;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->timeZone) {
            $res['timeZone'] = $this->timeZone;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['namespace'])) {
            $model->namespace = $map['namespace'];
        }
        if (isset($map['ossUrl'])) {
            $model->ossUrl = $map['ossUrl'];
        }
        if (isset($map['sequenceId'])) {
            $model->sequenceId = $map['sequenceId'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['timeZone'])) {
            $model->timeZone = $map['timeZone'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
