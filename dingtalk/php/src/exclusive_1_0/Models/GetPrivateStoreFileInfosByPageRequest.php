<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPrivateStoreFileInfosByPageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1680493837426
     *
     * @var int
     */
    public $fileCreateTime;

    /**
     * @var string
     */
    public $fileStatus;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $order;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'fileCreateTime' => 'fileCreateTime',
        'fileStatus' => 'fileStatus',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'order' => 'order',
        'targetCorpId' => 'targetCorpId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileCreateTime) {
            $res['fileCreateTime'] = $this->fileCreateTime;
        }
        if (null !== $this->fileStatus) {
            $res['fileStatus'] = $this->fileStatus;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPrivateStoreFileInfosByPageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileCreateTime'])) {
            $model->fileCreateTime = $map['fileCreateTime'];
        }
        if (isset($map['fileStatus'])) {
            $model->fileStatus = $map['fileStatus'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
