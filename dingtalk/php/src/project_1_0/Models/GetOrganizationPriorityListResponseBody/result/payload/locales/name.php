<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetOrganizationPriorityListResponseBody\result\payload\locales;

use AlibabaCloud\Tea\Model;

class name extends Model
{
    /**
     * @description 英文名
     *
     * @var string
     */
    public $en;

    /**
     * @description 中文名
     *
     * @var string
     */
    public $zh;
    protected $_name = [
        'en' => 'en',
        'zh' => 'zh',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->en) {
            $res['en'] = $this->en;
        }
        if (null !== $this->zh) {
            $res['zh'] = $this->zh;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return name
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['en'])) {
            $model->en = $map['en'];
        }
        if (isset($map['zh'])) {
            $model->zh = $map['zh'];
        }

        return $model;
    }
}
