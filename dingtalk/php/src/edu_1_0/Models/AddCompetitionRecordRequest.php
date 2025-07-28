<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddCompetitionRecordRequest extends Model
{
    /**
     * @example 5F44C
     *
     * @var string
     */
    public $competitionCode;

    /**
     * @example edu
     *
     * @var string
     */
    public $groupTemplateCode;

    /**
     * @var bool
     */
    public $joinGroup;

    /**
     * @example 小明
     *
     * @var string
     */
    public $participantName;

    /**
     * @example VYn5fYjORJMi
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'competitionCode' => 'competitionCode',
        'groupTemplateCode' => 'groupTemplateCode',
        'joinGroup' => 'joinGroup',
        'participantName' => 'participantName',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->competitionCode) {
            $res['competitionCode'] = $this->competitionCode;
        }
        if (null !== $this->groupTemplateCode) {
            $res['groupTemplateCode'] = $this->groupTemplateCode;
        }
        if (null !== $this->joinGroup) {
            $res['joinGroup'] = $this->joinGroup;
        }
        if (null !== $this->participantName) {
            $res['participantName'] = $this->participantName;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCompetitionRecordRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['competitionCode'])) {
            $model->competitionCode = $map['competitionCode'];
        }
        if (isset($map['groupTemplateCode'])) {
            $model->groupTemplateCode = $map['groupTemplateCode'];
        }
        if (isset($map['joinGroup'])) {
            $model->joinGroup = $map['joinGroup'];
        }
        if (isset($map['participantName'])) {
            $model->participantName = $map['participantName'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
