<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody\data\groupAttributes\listDynamicAttr;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody\data\groupAttributes\listReceiver;
use AlibabaCloud\Tea\Model;

class groupAttributes extends Model
{
    /**
     * @var int
     */
    public $configGroupId;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $groupTopic;

    /**
     * @var string
     */
    public $groupType;

    /**
     * @var listDynamicAttr[]
     */
    public $listDynamicAttr;

    /**
     * @var listReceiver[]
     */
    public $listReceiver;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @var string
     */
    public $ownerJobNo;

    /**
     * @var string
     */
    public $subRuleCode;
    protected $_name = [
        'configGroupId'      => 'configGroupId',
        'corpId'             => 'corpId',
        'groupTopic'         => 'groupTopic',
        'groupType'          => 'groupType',
        'listDynamicAttr'    => 'listDynamicAttr',
        'listReceiver'       => 'listReceiver',
        'openConversationId' => 'openConversationId',
        'ownerJobNo'         => 'ownerJobNo',
        'subRuleCode'        => 'subRuleCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->configGroupId) {
            $res['configGroupId'] = $this->configGroupId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->groupTopic) {
            $res['groupTopic'] = $this->groupTopic;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->listDynamicAttr) {
            $res['listDynamicAttr'] = [];
            if (null !== $this->listDynamicAttr && \is_array($this->listDynamicAttr)) {
                $n = 0;
                foreach ($this->listDynamicAttr as $item) {
                    $res['listDynamicAttr'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->listReceiver) {
            $res['listReceiver'] = [];
            if (null !== $this->listReceiver && \is_array($this->listReceiver)) {
                $n = 0;
                foreach ($this->listReceiver as $item) {
                    $res['listReceiver'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->ownerJobNo) {
            $res['ownerJobNo'] = $this->ownerJobNo;
        }
        if (null !== $this->subRuleCode) {
            $res['subRuleCode'] = $this->subRuleCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupAttributes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['configGroupId'])) {
            $model->configGroupId = $map['configGroupId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['groupTopic'])) {
            $model->groupTopic = $map['groupTopic'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['listDynamicAttr'])) {
            if (!empty($map['listDynamicAttr'])) {
                $model->listDynamicAttr = [];
                $n                      = 0;
                foreach ($map['listDynamicAttr'] as $item) {
                    $model->listDynamicAttr[$n++] = null !== $item ? listDynamicAttr::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['listReceiver'])) {
            if (!empty($map['listReceiver'])) {
                $model->listReceiver = [];
                $n                   = 0;
                foreach ($map['listReceiver'] as $item) {
                    $model->listReceiver[$n++] = null !== $item ? listReceiver::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['ownerJobNo'])) {
            $model->ownerJobNo = $map['ownerJobNo'];
        }
        if (isset($map['subRuleCode'])) {
            $model->subRuleCode = $map['subRuleCode'];
        }

        return $model;
    }
}
