<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatAiTravelListRequest\paramList;
use AlibabaCloud\Tea\Model;

class ChatAiTravelListRequest extends Model
{
    /**
     * @var paramList[]
     */
    public $paramList;

    /**
     * @example qaz12345900
     *
     * @var string
     */
    public $travelId;
    protected $_name = [
        'paramList' => 'paramList',
        'travelId'  => 'travelId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->paramList) {
            $res['paramList'] = [];
            if (null !== $this->paramList && \is_array($this->paramList)) {
                $n = 0;
                foreach ($this->paramList as $item) {
                    $res['paramList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->travelId) {
            $res['travelId'] = $this->travelId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatAiTravelListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['paramList'])) {
            if (!empty($map['paramList'])) {
                $model->paramList = [];
                $n                = 0;
                foreach ($map['paramList'] as $item) {
                    $model->paramList[$n++] = null !== $item ? paramList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['travelId'])) {
            $model->travelId = $map['travelId'];
        }

        return $model;
    }
}
