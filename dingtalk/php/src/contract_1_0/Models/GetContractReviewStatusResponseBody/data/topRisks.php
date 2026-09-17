<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewStatusResponseBody\data;

use AlibabaCloud\Tea\Model;

class topRisks extends Model
{
    /**
     * @var string
     */
    public $level;

    /**
     * @var string
     */
    public $suggestion;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'level' => 'level',
        'suggestion' => 'suggestion',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->level) {
            $res['level'] = $this->level;
        }
        if (null !== $this->suggestion) {
            $res['suggestion'] = $this->suggestion;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return topRisks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['level'])) {
            $model->level = $map['level'];
        }
        if (isset($map['suggestion'])) {
            $model->suggestion = $map['suggestion'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
