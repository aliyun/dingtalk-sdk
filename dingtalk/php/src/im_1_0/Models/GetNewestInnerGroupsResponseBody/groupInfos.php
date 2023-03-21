<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetNewestInnerGroupsResponseBody;

use AlibabaCloud\Tea\Model;

class groupInfos extends Model
{
    /**
     * @description 群头像。
     *
     * @var string
     */
    public $icon;

    /**
     * @description 群成员人数。
     *
     * @var string
     */
    public $memberAmount;

    /**
     * @description 群聊会话id。
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 群名称。
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'icon'               => 'icon',
        'memberAmount'       => 'memberAmount',
        'openConversationId' => 'openConversationId',
        'title'              => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->memberAmount) {
            $res['memberAmount'] = $this->memberAmount;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['memberAmount'])) {
            $model->memberAmount = $map['memberAmount'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
