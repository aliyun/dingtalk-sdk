<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizationPriorityListResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizationPriorityListResponseBody\result\payload\locales;
use AlibabaCloud\Tea\Model;

class payload extends Model
{
    /**
     * @description 优先级多语言
     *
     * @var locales
     */
    public $locales;
    protected $_name = [
        'locales' => 'locales',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->locales) {
            $res['locales'] = null !== $this->locales ? $this->locales->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return payload
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['locales'])) {
            $model->locales = locales::fromMap($map['locales']);
        }

        return $model;
    }
}
