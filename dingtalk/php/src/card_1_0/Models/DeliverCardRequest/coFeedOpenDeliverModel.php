<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest;

use AlibabaCloud\Tea\Model;

class coFeedOpenDeliverModel extends Model
{
    /**
     * @description 【必填】业务标识
     *
     * @var string
     */
    public $bizTag;

    /**
     * @description 【必填】协作场域下的排序时间
     *
     * @var int
     */
    public $gmtTimeLine;
    protected $_name = [
        'bizTag'      => 'bizTag',
        'gmtTimeLine' => 'gmtTimeLine',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizTag) {
            $res['bizTag'] = $this->bizTag;
        }
        if (null !== $this->gmtTimeLine) {
            $res['gmtTimeLine'] = $this->gmtTimeLine;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return coFeedOpenDeliverModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizTag'])) {
            $model->bizTag = $map['bizTag'];
        }
        if (isset($map['gmtTimeLine'])) {
            $model->gmtTimeLine = $map['gmtTimeLine'];
        }

        return $model;
    }
}
