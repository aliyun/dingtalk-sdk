<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\AddTeamResponseBody\team;
use AlibabaCloud\Tea\Model;

class AddTeamResponseBody extends Model
{
    /**
     * @var team
     */
    public $team;
    protected $_name = [
        'team' => 'team',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->team) {
            $res['team'] = null !== $this->team ? $this->team->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddTeamResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['team'])) {
            $model->team = team::fromMap($map['team']);
        }

        return $model;
    }
}
