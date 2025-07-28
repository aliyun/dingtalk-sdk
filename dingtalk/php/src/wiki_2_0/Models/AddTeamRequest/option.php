<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\AddTeamRequest;

use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\AddTeamRequest\option\icon;
use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @example team_cover
     *
     * @var string
     */
    public $cover;

    /**
     * @example team_description
     *
     * @var string
     */
    public $description;

    /**
     * @var icon
     */
    public $icon;
    protected $_name = [
        'cover' => 'cover',
        'description' => 'description',
        'icon' => 'icon',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cover) {
            $res['cover'] = $this->cover;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = null !== $this->icon ? $this->icon->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cover'])) {
            $model->cover = $map['cover'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = icon::fromMap($map['icon']);
        }

        return $model;
    }
}
