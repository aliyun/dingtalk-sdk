<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\Tea\Model;

class PullDataByPageRequest extends Model
{
    /**
     * @description 要拉取的主数据模型id。
     *
     * @var string
     */
    public $dataModelId;

    /**
     * @description 用于过滤时间范围的字段，包含数据创建时间(dataGmtCreate)和数据修改时间(dataGmtModified)，如不传则不过滤。
     *
     * @var string
     */
    public $datetimeFilterField;

    /**
     * @description 当配置了datetimeFilterField字段后，数据的时间起点，如果不传则将最早一条数据作为起点。
     *
     * @var int
     */
    public $minDatetime;

    /**
     * @description 当配置了datetimeFilterField字段后，数据的时间终点，如果不传则按最新一条数据作为终点。
     *
     * @var int
     */
    public $maxDatetime;

    /**
     * @description 用于翻页的游标，如果为空则从第一条数据开始查询。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 单次获取的最大记录条数，最大限制100条。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 同步数据的应用id，isv应用传isv应用id，企业自建应用传agentId。
     *
     * @var string
     */
    public $appId;
    protected $_name = [
        'dataModelId'         => 'dataModelId',
        'datetimeFilterField' => 'datetimeFilterField',
        'minDatetime'         => 'minDatetime',
        'maxDatetime'         => 'maxDatetime',
        'nextToken'           => 'nextToken',
        'maxResults'          => 'maxResults',
        'appId'               => 'appId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dataModelId) {
            $res['dataModelId'] = $this->dataModelId;
        }
        if (null !== $this->datetimeFilterField) {
            $res['datetimeFilterField'] = $this->datetimeFilterField;
        }
        if (null !== $this->minDatetime) {
            $res['minDatetime'] = $this->minDatetime;
        }
        if (null !== $this->maxDatetime) {
            $res['maxDatetime'] = $this->maxDatetime;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
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
        if (isset($map['dataModelId'])) {
            $model->dataModelId = $map['dataModelId'];
        }
        if (isset($map['datetimeFilterField'])) {
            $model->datetimeFilterField = $map['datetimeFilterField'];
        }
        if (isset($map['minDatetime'])) {
            $model->minDatetime = $map['minDatetime'];
        }
        if (isset($map['maxDatetime'])) {
            $model->maxDatetime = $map['maxDatetime'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }

        return $model;
    }
}
