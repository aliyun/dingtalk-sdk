<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetReviewChecklistResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetReviewChecklistResponseBody\data\checklist;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var checklist
     */
    public $checklist;
    protected $_name = [
        'checklist' => 'checklist',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->checklist) {
            $res['checklist'] = null !== $this->checklist ? $this->checklist->toMap() : null;
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
        if (isset($map['checklist'])) {
            $model->checklist = checklist::fromMap($map['checklist']);
        }

        return $model;
    }
}
