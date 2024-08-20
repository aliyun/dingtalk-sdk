<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignResponseBody\approvalSummary\title;
use AlibabaCloud\Tea\Model;

class approvalSummary extends Model
{
    /**
     * @var title
     */
    public $title;
    protected $_name = [
        'title' => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->title) {
            $res['title'] = null !== $this->title ? $this->title->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return approvalSummary
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['title'])) {
            $model->title = title::fromMap($map['title']);
        }

        return $model;
    }
}
