<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripInvoiceRequest\invoiceDetailList;

use AlibabaCloud\Tea\Model;

class travelItineraryInfoList extends Model
{
    /**
     * @var string
     */
    public $travelItineraryUrl;
    protected $_name = [
        'travelItineraryUrl' => 'travelItineraryUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->travelItineraryUrl) {
            $res['travelItineraryUrl'] = $this->travelItineraryUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return travelItineraryInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['travelItineraryUrl'])) {
            $model->travelItineraryUrl = $map['travelItineraryUrl'];
        }

        return $model;
    }
}
