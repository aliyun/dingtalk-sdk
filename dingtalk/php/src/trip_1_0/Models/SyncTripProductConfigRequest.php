<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripProductConfigRequest\tripProductConfigList;
use AlibabaCloud\Tea\Model;

class SyncTripProductConfigRequest extends Model
{
    /**
     * @var string
     */
    public $targetCorpId;

    /**
     * @var tripProductConfigList[]
     */
    public $tripProductConfigList;
    protected $_name = [
        'targetCorpId'          => 'targetCorpId',
        'tripProductConfigList' => 'tripProductConfigList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->tripProductConfigList) {
            $res['tripProductConfigList'] = [];
            if (null !== $this->tripProductConfigList && \is_array($this->tripProductConfigList)) {
                $n = 0;
                foreach ($this->tripProductConfigList as $item) {
                    $res['tripProductConfigList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncTripProductConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['tripProductConfigList'])) {
            if (!empty($map['tripProductConfigList'])) {
                $model->tripProductConfigList = [];
                $n                            = 0;
                foreach ($map['tripProductConfigList'] as $item) {
                    $model->tripProductConfigList[$n++] = null !== $item ? tripProductConfigList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
