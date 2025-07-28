<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DIgitalStoreMessagePushShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $messageDataListShrink;
    protected $_name = [
        'messageDataListShrink' => 'messageDataList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->messageDataListShrink) {
            $res['messageDataList'] = $this->messageDataListShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DIgitalStoreMessagePushShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['messageDataList'])) {
            $model->messageDataListShrink = $map['messageDataList'];
        }

        return $model;
    }
}
