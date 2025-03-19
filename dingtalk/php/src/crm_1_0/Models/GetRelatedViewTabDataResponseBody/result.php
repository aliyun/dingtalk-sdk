<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelatedViewTabDataResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelatedViewTabDataResponseBody\result\page;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var page
     */
    public $page;
    protected $_name = [
        'page' => 'page',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->page) {
            $res['page'] = null !== $this->page ? $this->page->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['page'])) {
            $model->page = page::fromMap($map['page']);
        }

        return $model;
    }
}
