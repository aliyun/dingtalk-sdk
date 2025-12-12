<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\UpdateExportDeviceStatisticRequest\records;
use AlibabaCloud\Tea\Model;

class UpdateExportDeviceStatisticRequest extends Model
{
    /**
     * @var string
     */
    public $creatorCorpId;

    /**
     * @var string
     */
    public $creatorUnionId;

    /**
     * @var records[]
     */
    public $records;

    /**
     * @var string
     */
    public $taskId;
    protected $_name = [
        'creatorCorpId' => 'creatorCorpId',
        'creatorUnionId' => 'creatorUnionId',
        'records' => 'records',
        'taskId' => 'taskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorCorpId) {
            $res['creatorCorpId'] = $this->creatorCorpId;
        }
        if (null !== $this->creatorUnionId) {
            $res['creatorUnionId'] = $this->creatorUnionId;
        }
        if (null !== $this->records) {
            $res['records'] = [];
            if (null !== $this->records && \is_array($this->records)) {
                $n = 0;
                foreach ($this->records as $item) {
                    $res['records'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateExportDeviceStatisticRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorCorpId'])) {
            $model->creatorCorpId = $map['creatorCorpId'];
        }
        if (isset($map['creatorUnionId'])) {
            $model->creatorUnionId = $map['creatorUnionId'];
        }
        if (isset($map['records'])) {
            if (!empty($map['records'])) {
                $model->records = [];
                $n = 0;
                foreach ($map['records'] as $item) {
                    $model->records[$n++] = null !== $item ? records::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
