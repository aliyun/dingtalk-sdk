<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\UpdateServiceRecordRestrictResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $failCount;

    /**
     * @var string[]
     */
    public $failedRecordIds;

    /**
     * @var int
     */
    public $successCount;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'failCount' => 'failCount',
        'failedRecordIds' => 'failedRecordIds',
        'successCount' => 'successCount',
        'total' => 'total',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->failCount) {
            $res['failCount'] = $this->failCount;
        }
        if (null !== $this->failedRecordIds) {
            $res['failedRecordIds'] = $this->failedRecordIds;
        }
        if (null !== $this->successCount) {
            $res['successCount'] = $this->successCount;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failCount'])) {
            $model->failCount = $map['failCount'];
        }
        if (isset($map['failedRecordIds'])) {
            if (!empty($map['failedRecordIds'])) {
                $model->failedRecordIds = $map['failedRecordIds'];
            }
        }
        if (isset($map['successCount'])) {
            $model->successCount = $map['successCount'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
