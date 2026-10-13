<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateAICardResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example FINISH
     *
     * @var string
     */
    public $flowStatus;

    /**
     * @example a2ui_order_001
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @example update_001
     *
     * @var string
     */
    public $outUpdateId;
    protected $_name = [
        'flowStatus' => 'flowStatus',
        'outTrackId' => 'outTrackId',
        'outUpdateId' => 'outUpdateId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->flowStatus) {
            $res['flowStatus'] = $this->flowStatus;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->outUpdateId) {
            $res['outUpdateId'] = $this->outUpdateId;
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
        if (isset($map['flowStatus'])) {
            $model->flowStatus = $map['flowStatus'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['outUpdateId'])) {
            $model->outUpdateId = $map['outUpdateId'];
        }

        return $model;
    }
}
