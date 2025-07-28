<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverWithDelegateResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverWithDelegateResponseBody\result\deliverResults;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var deliverResults[]
     */
    public $deliverResults;

    /**
     * @example out_track_id_xxx
     *
     * @var string
     */
    public $outTrackId;
    protected $_name = [
        'deliverResults' => 'deliverResults',
        'outTrackId' => 'outTrackId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deliverResults) {
            $res['deliverResults'] = [];
            if (null !== $this->deliverResults && \is_array($this->deliverResults)) {
                $n = 0;
                foreach ($this->deliverResults as $item) {
                    $res['deliverResults'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
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
        if (isset($map['deliverResults'])) {
            if (!empty($map['deliverResults'])) {
                $model->deliverResults = [];
                $n = 0;
                foreach ($map['deliverResults'] as $item) {
                    $model->deliverResults[$n++] = null !== $item ? deliverResults::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }

        return $model;
    }
}
