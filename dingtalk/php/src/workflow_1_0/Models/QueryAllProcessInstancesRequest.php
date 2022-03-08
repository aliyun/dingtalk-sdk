<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAllProcessInstancesRequest extends Model
{
    /**
     * @description 应用编码
     *
     * @var string
     */
    public $appUuid;

    /**
     * @description 结束时间
     *
     * @var int
     */
    public $endTimeInMills;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页起始值
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 模板编码
     *
     * @var string
     */
    public $processCode;

    /**
     * @description 开始时间
     *
     * @var int
     */
    public $startTimeInMills;
    protected $_name = [
        'appUuid'          => 'appUuid',
        'endTimeInMills'   => 'endTimeInMills',
        'maxResults'       => 'maxResults',
        'nextToken'        => 'nextToken',
        'processCode'      => 'processCode',
        'startTimeInMills' => 'startTimeInMills',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->endTimeInMills) {
            $res['endTimeInMills'] = $this->endTimeInMills;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->startTimeInMills) {
            $res['startTimeInMills'] = $this->startTimeInMills;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAllProcessInstancesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['endTimeInMills'])) {
            $model->endTimeInMills = $map['endTimeInMills'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['startTimeInMills'])) {
            $model->startTimeInMills = $map['startTimeInMills'];
        }

        return $model;
    }
}
