<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DIgitalStoreMessagePushRequest\messageDataList;
use AlibabaCloud\Tea\Model;

class DIgitalStoreMessagePushRequest extends Model
{
    /**
     * @var messageDataList[]
     */
    public $messageDataList;
    protected $_name = [
        'messageDataList' => 'messageDataList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->messageDataList) {
            $res['messageDataList'] = [];
            if (null !== $this->messageDataList && \is_array($this->messageDataList)) {
                $n = 0;
                foreach ($this->messageDataList as $item) {
                    $res['messageDataList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DIgitalStoreMessagePushRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['messageDataList'])) {
            if (!empty($map['messageDataList'])) {
                $model->messageDataList = [];
                $n = 0;
                foreach ($map['messageDataList'] as $item) {
                    $model->messageDataList[$n++] = null !== $item ? messageDataList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
