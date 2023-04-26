<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\Tea\Model;

class PullDataByPageRequest extends Model
{
    /**
     * @var string
     */
    public $appId;

    /**
     * @var string
     */
    public $dataModelId;

    /**
     * @var string
     */
    public $datetimeFilterField;

    /**
     * @var int
     */
    public $maxDatetime;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var int
     */
    public $minDatetime;

    /**
     * @var string
     */
    public $nextToken;
    protected $_name = [
        'appId'               => 'appId',
        'dataModelId'         => 'dataModelId',
        'datetimeFilterField' => 'datetimeFilterField',
        'maxDatetime'         => 'maxDatetime',
        'maxResults'          => 'maxResults',
        'minDatetime'         => 'minDatetime',
        'nextToken'           => 'nextToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->dataModelId) {
            $res['dataModelId'] = $this->dataModelId;
        }
        if (null !== $this->datetimeFilterField) {
            $res['datetimeFilterField'] = $this->datetimeFilterField;
        }
        if (null !== $this->maxDatetime) {
            $res['maxDatetime'] = $this->maxDatetime;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->minDatetime) {
            $res['minDatetime'] = $this->minDatetime;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PullDataByPageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['dataModelId'])) {
            $model->dataModelId = $map['dataModelId'];
        }
        if (isset($map['datetimeFilterField'])) {
            $model->datetimeFilterField = $map['datetimeFilterField'];
        }
        if (isset($map['maxDatetime'])) {
            $model->maxDatetime = $map['maxDatetime'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['minDatetime'])) {
            $model->minDatetime = $map['minDatetime'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
