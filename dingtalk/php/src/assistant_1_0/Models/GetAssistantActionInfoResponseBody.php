<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetAssistantActionInfoResponseBody\actionList;
use AlibabaCloud\Tea\Model;

class GetAssistantActionInfoResponseBody extends Model
{
    /**
     * @var actionList[]
     */
    public $actionList;

    /**
     * @var string
     */
    public $assistantId;

    /**
     * @var string
     */
    public $corpId;
    protected $_name = [
        'actionList'  => 'actionList',
        'assistantId' => 'assistantId',
        'corpId'      => 'corpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionList) {
            $res['actionList'] = [];
            if (null !== $this->actionList && \is_array($this->actionList)) {
                $n = 0;
                foreach ($this->actionList as $item) {
                    $res['actionList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->assistantId) {
            $res['assistantId'] = $this->assistantId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAssistantActionInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionList'])) {
            if (!empty($map['actionList'])) {
                $model->actionList = [];
                $n                 = 0;
                foreach ($map['actionList'] as $item) {
                    $model->actionList[$n++] = null !== $item ? actionList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['assistantId'])) {
            $model->assistantId = $map['assistantId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }

        return $model;
    }
}
