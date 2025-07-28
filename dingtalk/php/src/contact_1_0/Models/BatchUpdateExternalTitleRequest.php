<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\BatchUpdateExternalTitleRequest\updateTitleModelList;
use AlibabaCloud\Tea\Model;

class BatchUpdateExternalTitleRequest extends Model
{
    /**
     * @var string
     */
    public $operatorUserId;

    /**
     * @var updateTitleModelList[]
     */
    public $updateTitleModelList;
    protected $_name = [
        'operatorUserId' => 'operatorUserId',
        'updateTitleModelList' => 'updateTitleModelList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->updateTitleModelList) {
            $res['updateTitleModelList'] = [];
            if (null !== $this->updateTitleModelList && \is_array($this->updateTitleModelList)) {
                $n = 0;
                foreach ($this->updateTitleModelList as $item) {
                    $res['updateTitleModelList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchUpdateExternalTitleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['updateTitleModelList'])) {
            if (!empty($map['updateTitleModelList'])) {
                $model->updateTitleModelList = [];
                $n = 0;
                foreach ($map['updateTitleModelList'] as $item) {
                    $model->updateTitleModelList[$n++] = null !== $item ? updateTitleModelList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
