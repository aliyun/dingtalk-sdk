<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTeamRequest extends Model
{
    /**
     * @var string
     */
    public $dialectCode;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string[]
     */
    public $sceneCodes;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $teamCode;
    protected $_name = [
        'dialectCode' => 'dialectCode',
        'name' => 'name',
        'sceneCodes' => 'sceneCodes',
        'teamCode' => 'teamCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dialectCode) {
            $res['dialectCode'] = $this->dialectCode;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->sceneCodes) {
            $res['sceneCodes'] = $this->sceneCodes;
        }
        if (null !== $this->teamCode) {
            $res['teamCode'] = $this->teamCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTeamRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dialectCode'])) {
            $model->dialectCode = $map['dialectCode'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['sceneCodes'])) {
            if (!empty($map['sceneCodes'])) {
                $model->sceneCodes = $map['sceneCodes'];
            }
        }
        if (isset($map['teamCode'])) {
            $model->teamCode = $map['teamCode'];
        }

        return $model;
    }
}
