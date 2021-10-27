<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAllProcessInstancesRequest extends Model
{
    /**
     * @description 分页起始值
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 开始时间
     *
     * @var int
     */
    public $startTimeInMills;

    /**
     * @description 结束时间
     *
     * @var int
     */
    public $endTimeInMills;

    /**
     * @description 模板编码
     *
     * @var string
     */
    public $processCode;

    /**
     * @description 应用编码
     *
     * @var string
     */
    public $appUuid;
    protected $_name = [
        'nextToken'        => 'nextToken',
        'maxResults'       => 'maxResults',
        'startTimeInMills' => 'startTimeInMills',
        'endTimeInMills'   => 'endTimeInMills',
        'processCode'      => 'processCode',
        'appUuid'          => 'appUuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->startTimeInMills) {
            $res['startTimeInMills'] = $this->startTimeInMills;
        }
        if (null !== $this->endTimeInMills) {
            $res['endTimeInMills'] = $this->endTimeInMills;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
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
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['startTimeInMills'])) {
            $model->startTimeInMills = $map['startTimeInMills'];
        }
        if (isset($map['endTimeInMills'])) {
            $model->endTimeInMills = $map['endTimeInMills'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }

        return $model;
    }
}
