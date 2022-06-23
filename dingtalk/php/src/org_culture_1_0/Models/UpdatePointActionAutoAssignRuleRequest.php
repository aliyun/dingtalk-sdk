<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\UpdatePointActionAutoAssignRuleRequest\updatePointRuleRequestDTOList;
use AlibabaCloud\Tea\Model;

class UpdatePointActionAutoAssignRuleRequest extends Model
{
    /**
     * @description 行为规则列表
     *
     * @var updatePointRuleRequestDTOList[]
     */
    public $updatePointRuleRequestDTOList;

    /**
     * @description 操作人userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'updatePointRuleRequestDTOList' => 'updatePointRuleRequestDTOList',
        'userId'                        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->updatePointRuleRequestDTOList) {
            $res['updatePointRuleRequestDTOList'] = [];
            if (null !== $this->updatePointRuleRequestDTOList && \is_array($this->updatePointRuleRequestDTOList)) {
                $n = 0;
                foreach ($this->updatePointRuleRequestDTOList as $item) {
                    $res['updatePointRuleRequestDTOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdatePointActionAutoAssignRuleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['updatePointRuleRequestDTOList'])) {
            if (!empty($map['updatePointRuleRequestDTOList'])) {
                $model->updatePointRuleRequestDTOList = [];
                $n                                    = 0;
                foreach ($map['updatePointRuleRequestDTOList'] as $item) {
                    $model->updatePointRuleRequestDTOList[$n++] = null !== $item ? updatePointRuleRequestDTOList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
