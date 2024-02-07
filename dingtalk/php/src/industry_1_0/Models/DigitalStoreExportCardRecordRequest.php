<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreExportCardRecordRequest extends Model
{
    /**
     * @example 1696917858123
     *
     * @var int
     */
    public $beginTime;

    /**
     * @example 1696918858123
     *
     * @var int
     */
    public $endTime;

    /**
     * @var int[]
     */
    public $ids;

    /**
     * @example 场景卡片名称
     *
     * @var string
     */
    public $sceneCardName;
    protected $_name = [
        'beginTime'     => 'beginTime',
        'endTime'       => 'endTime',
        'ids'           => 'ids',
        'sceneCardName' => 'sceneCardName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->beginTime) {
            $res['beginTime'] = $this->beginTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->ids) {
            $res['ids'] = $this->ids;
        }
        if (null !== $this->sceneCardName) {
            $res['sceneCardName'] = $this->sceneCardName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreExportCardRecordRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['beginTime'])) {
            $model->beginTime = $map['beginTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['ids'])) {
            if (!empty($map['ids'])) {
                $model->ids = $map['ids'];
            }
        }
        if (isset($map['sceneCardName'])) {
            $model->sceneCardName = $map['sceneCardName'];
        }

        return $model;
    }
}
