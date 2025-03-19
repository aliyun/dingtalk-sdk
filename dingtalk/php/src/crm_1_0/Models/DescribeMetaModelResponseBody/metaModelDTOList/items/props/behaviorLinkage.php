<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeMetaModelResponseBody\metaModelDTOList\items\props;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeMetaModelResponseBody\metaModelDTOList\items\props\behaviorLinkage\targets;
use AlibabaCloud\Tea\Model;

class behaviorLinkage extends Model
{
    /**
     * @example option_0
     *
     * @var string
     */
    public $optionKey;

    /**
     * @var targets[]
     */
    public $targets;
    protected $_name = [
        'optionKey' => 'optionKey',
        'targets' => 'targets',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->optionKey) {
            $res['optionKey'] = $this->optionKey;
        }
        if (null !== $this->targets) {
            $res['targets'] = [];
            if (null !== $this->targets && \is_array($this->targets)) {
                $n = 0;
                foreach ($this->targets as $item) {
                    $res['targets'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return behaviorLinkage
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['optionKey'])) {
            $model->optionKey = $map['optionKey'];
        }
        if (isset($map['targets'])) {
            if (!empty($map['targets'])) {
                $model->targets = [];
                $n = 0;
                foreach ($map['targets'] as $item) {
                    $model->targets[$n++] = null !== $item ? targets::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
