<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\ListReviewChecklistsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\ListReviewChecklistsResponseBody\data\checklists;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var checklists[]
     */
    public $checklists;

    /**
     * @var string
     */
    public $corpId;
    protected $_name = [
        'checklists' => 'checklists',
        'corpId' => 'corp_id',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->checklists) {
            $res['checklists'] = [];
            if (null !== $this->checklists && \is_array($this->checklists)) {
                $n = 0;
                foreach ($this->checklists as $item) {
                    $res['checklists'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->corpId) {
            $res['corp_id'] = $this->corpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['checklists'])) {
            if (!empty($map['checklists'])) {
                $model->checklists = [];
                $n = 0;
                foreach ($map['checklists'] as $item) {
                    $model->checklists[$n++] = null !== $item ? checklists::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['corp_id'])) {
            $model->corpId = $map['corp_id'];
        }

        return $model;
    }
}
