<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\AddTeamRequest\option;
use AlibabaCloud\Tea\Model;

class AddTeamRequest extends Model
{
    /**
     * @example team_name
     *
     * @var string
     */
    public $name;

    /**
     * @var option
     */
    public $option;

    /**
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'name'       => 'name',
        'option'     => 'option',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->option) {
            $res['option'] = null !== $this->option ? $this->option->toMap() : null;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddTeamRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['option'])) {
            $model->option = option::fromMap($map['option']);
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
