<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesResponseBody\items\creator;
use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesResponseBody\items\modifier;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var creator
     */
    public $creator;

    /**
     * @example uuid
     *
     * @var string
     */
    public $dentryUuid;

    /**
     * @var modifier
     */
    public $modifier;

    /**
     * @example name
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'creator'    => 'creator',
        'dentryUuid' => 'dentryUuid',
        'modifier'   => 'modifier',
        'name'       => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creator) {
            $res['creator'] = null !== $this->creator ? $this->creator->toMap() : null;
        }
        if (null !== $this->dentryUuid) {
            $res['dentryUuid'] = $this->dentryUuid;
        }
        if (null !== $this->modifier) {
            $res['modifier'] = null !== $this->modifier ? $this->modifier->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creator'])) {
            $model->creator = creator::fromMap($map['creator']);
        }
        if (isset($map['dentryUuid'])) {
            $model->dentryUuid = $map['dentryUuid'];
        }
        if (isset($map['modifier'])) {
            $model->modifier = modifier::fromMap($map['modifier']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
