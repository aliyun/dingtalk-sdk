<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchSendOTOResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $flowControlledStaffIdList;

    /**
     * @var string[]
     */
    public $invalidStaffIdList;

    /**
     * @var string
     */
    public $processQueryKey;
    protected $_name = [
        'flowControlledStaffIdList' => 'flowControlledStaffIdList',
        'invalidStaffIdList'        => 'invalidStaffIdList',
        'processQueryKey'           => 'processQueryKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->flowControlledStaffIdList) {
            $res['flowControlledStaffIdList'] = $this->flowControlledStaffIdList;
        }
        if (null !== $this->invalidStaffIdList) {
            $res['invalidStaffIdList'] = $this->invalidStaffIdList;
        }
        if (null !== $this->processQueryKey) {
            $res['processQueryKey'] = $this->processQueryKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchSendOTOResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['flowControlledStaffIdList'])) {
            if (!empty($map['flowControlledStaffIdList'])) {
                $model->flowControlledStaffIdList = $map['flowControlledStaffIdList'];
            }
        }
        if (isset($map['invalidStaffIdList'])) {
            if (!empty($map['invalidStaffIdList'])) {
                $model->invalidStaffIdList = $map['invalidStaffIdList'];
            }
        }
        if (isset($map['processQueryKey'])) {
            $model->processQueryKey = $map['processQueryKey'];
        }

        return $model;
    }
}
