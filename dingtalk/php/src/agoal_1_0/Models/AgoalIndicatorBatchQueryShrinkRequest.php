<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class AgoalIndicatorBatchQueryShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $codeListShrink;
    protected $_name = [
        'codeListShrink' => 'codeList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->codeListShrink) {
            $res['codeList'] = $this->codeListShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AgoalIndicatorBatchQueryShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['codeList'])) {
            $model->codeListShrink = $map['codeList'];
        }

        return $model;
    }
}
