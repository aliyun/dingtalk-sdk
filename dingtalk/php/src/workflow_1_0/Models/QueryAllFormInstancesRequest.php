<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAllFormInstancesRequest extends Model
{
    /**
     * @description 分页游标，第一次调用传空或者null
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 翻页size
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 开始时间戳
     *
     * @var int
     */
    public $startTimeInMills;

    /**
     * @description 结束时间戳
     *
     * @var int
     */
    public $endTimeInMills;

    /**
     * @description 应用搭建id
     *
     * @var string
     */
    public $appUuid;

    /**
     * @description 表单模板id
     *
     * @var string
     */
    public $formCode;
    protected $_name = [
        'nextToken'        => 'nextToken',
        'maxResults'       => 'maxResults',
        'startTimeInMills' => 'startTimeInMills',
        'endTimeInMills'   => 'endTimeInMills',
        'appUuid'          => 'appUuid',
        'formCode'         => 'formCode',
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
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAllFormInstancesRequest
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
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }

        return $model;
    }
}
