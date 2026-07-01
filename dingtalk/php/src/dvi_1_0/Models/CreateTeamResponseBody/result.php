<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\CreateTeamResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $teamCode;
    protected $_name = [
        'name' => 'name',
        'teamCode' => 'teamCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->teamCode) {
            $res['teamCode'] = $this->teamCode;
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['teamCode'])) {
            $model->teamCode = $map['teamCode'];
        }

        return $model;
    }
}
