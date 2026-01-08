<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\VideoCustomerSplitResponseBody\result;

use AlibabaCloud\Tea\Model;

class createServiceRecordResult extends Model
{
    /**
     * @var string[]
     */
    public $recordIds;

    /**
     * @var string
     */
    public $segmentId;
    protected $_name = [
        'recordIds' => 'recordIds',
        'segmentId' => 'segmentId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->recordIds) {
            $res['recordIds'] = $this->recordIds;
        }
        if (null !== $this->segmentId) {
            $res['segmentId'] = $this->segmentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return createServiceRecordResult
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['recordIds'])) {
            if (!empty($map['recordIds'])) {
                $model->recordIds = $map['recordIds'];
            }
        }
        if (isset($map['segmentId'])) {
            $model->segmentId = $map['segmentId'];
        }

        return $model;
    }
}
