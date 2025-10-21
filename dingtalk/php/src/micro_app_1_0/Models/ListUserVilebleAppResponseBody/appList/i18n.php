<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\ListUserVilebleAppResponseBody\appList;

use AlibabaCloud\Tea\Model;

class i18n extends Model
{
    /**
     * @var string
     */
    public $desc;

    /**
     * @var string
     */
    public $i18nKey;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'desc' => 'desc',
        'i18nKey' => 'i18n_key',
        'name' => 'name',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->i18nKey) {
            $res['i18n_key'] = $this->i18nKey;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return i18n
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['i18n_key'])) {
            $model->i18nKey = $map['i18n_key'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
