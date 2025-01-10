<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalAlignDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example COOPERATION
     *
     * @var string
     */
    public $alignType;

    /**
     * @description This parameter is required.
     *
     * @example 662e006fe4b0f579bbcxxxxx
     *
     * @var string
     */
    public $objectId;

    /**
     * @description This parameter is required.
     *
     * @example objective
     *
     * @var string
     */
    public $objectType;

    /**
     * @description This parameter is required.
     *
     * @example 662e006fe4b0f579bbcxxxxx
     *
     * @var string
     */
    public $objectiveId;
    protected $_name = [
        'alignType'   => 'alignType',
        'objectId'    => 'objectId',
        'objectType'  => 'objectType',
        'objectiveId' => 'objectiveId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->alignType) {
            $res['alignType'] = $this->alignType;
        }
        if (null !== $this->objectId) {
            $res['objectId'] = $this->objectId;
        }
        if (null !== $this->objectType) {
            $res['objectType'] = $this->objectType;
        }
        if (null !== $this->objectiveId) {
            $res['objectiveId'] = $this->objectiveId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalAlignDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['alignType'])) {
            $model->alignType = $map['alignType'];
        }
        if (isset($map['objectId'])) {
            $model->objectId = $map['objectId'];
        }
        if (isset($map['objectType'])) {
            $model->objectType = $map['objectType'];
        }
        if (isset($map['objectiveId'])) {
            $model->objectiveId = $map['objectiveId'];
        }

        return $model;
    }
}
