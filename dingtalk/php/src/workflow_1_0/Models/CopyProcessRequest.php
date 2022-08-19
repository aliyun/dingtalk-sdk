<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CopyProcessRequest\copyOptions;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\CopyProcessRequest\sourceProcessVOList;
use AlibabaCloud\Tea\Model;

class CopyProcessRequest extends Model
{
    /**
     * @description 复制选项
     *
     * @var copyOptions
     */
    public $copyOptions;

    /**
     * @var string
     */
    public $sourceCorpId;

    /**
     * @description 源模版列表
     *
     * @var sourceProcessVOList[]
     */
    public $sourceProcessVOList;
    protected $_name = [
        'copyOptions'         => 'copyOptions',
        'sourceCorpId'        => 'sourceCorpId',
        'sourceProcessVOList' => 'sourceProcessVOList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->copyOptions) {
            $res['copyOptions'] = null !== $this->copyOptions ? $this->copyOptions->toMap() : null;
        }
        if (null !== $this->sourceCorpId) {
            $res['sourceCorpId'] = $this->sourceCorpId;
        }
        if (null !== $this->sourceProcessVOList) {
            $res['sourceProcessVOList'] = [];
            if (null !== $this->sourceProcessVOList && \is_array($this->sourceProcessVOList)) {
                $n = 0;
                foreach ($this->sourceProcessVOList as $item) {
                    $res['sourceProcessVOList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyProcessRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['copyOptions'])) {
            $model->copyOptions = copyOptions::fromMap($map['copyOptions']);
        }
        if (isset($map['sourceCorpId'])) {
            $model->sourceCorpId = $map['sourceCorpId'];
        }
        if (isset($map['sourceProcessVOList'])) {
            if (!empty($map['sourceProcessVOList'])) {
                $model->sourceProcessVOList = [];
                $n                          = 0;
                foreach ($map['sourceProcessVOList'] as $item) {
                    $model->sourceProcessVOList[$n++] = null !== $item ? sourceProcessVOList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
