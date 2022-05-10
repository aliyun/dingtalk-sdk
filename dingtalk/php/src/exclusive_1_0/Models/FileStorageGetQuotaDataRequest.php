<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class FileStorageGetQuotaDataRequest extends Model
{
    /**
     * @description 结束时间
     *
     * @var string
     */
    public $endTime;

    /**
     * @description 开始时间
     *
     * @var string
     */
    public $startTime;

    /**
     * @description 企业的corpId
     *
     * @var string
     */
    public $targetCorpId;

    /**
     * @description 查询类型 0按天查询；1按月查询
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'endTime'      => 'endTime',
        'startTime'    => 'startTime',
        'targetCorpId' => 'targetCorpId',
        'type'         => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FileStorageGetQuotaDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
