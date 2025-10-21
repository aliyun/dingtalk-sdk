<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAudioFileRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example A1
     *
     * @var string
     */
    public $deviceType;

    /**
     * @var int
     */
    public $endTimestamp;

    /**
     * @example 5
     *
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
    public $sn;

    /**
     * @var int
     */
    public $startTimestamp;
    protected $_name = [
        'deviceType' => 'deviceType',
        'endTimestamp' => 'endTimestamp',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'sn' => 'sn',
        'startTimestamp' => 'startTimestamp',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceType) {
            $res['deviceType'] = $this->deviceType;
        }
        if (null !== $this->endTimestamp) {
            $res['endTimestamp'] = $this->endTimestamp;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->startTimestamp) {
            $res['startTimestamp'] = $this->startTimestamp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAudioFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceType'])) {
            $model->deviceType = $map['deviceType'];
        }
        if (isset($map['endTimestamp'])) {
            $model->endTimestamp = $map['endTimestamp'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['startTimestamp'])) {
            $model->startTimestamp = $map['startTimestamp'];
        }

        return $model;
    }
}
