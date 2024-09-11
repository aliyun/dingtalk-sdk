<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class AgoalCreateProgressRequest extends Model
{
    /**
     * @example 64bf87f8d7ace3616f0a1971
     *
     * @var string
     */
    public $krId;

    /**
     * @var bool
     */
    public $mergeIntoLatestProgress;

    /**
     * @example 662e006fe4b0f579bbcb10cf
     *
     * @var string
     */
    public $objectiveId;

    /**
     * @example 这是一条目标进展文本
     *
     * @var string
     */
    public $plainText;

    /**
     * @example 30
     *
     * @var int
     */
    public $progress;

    /**
     * @example naturalWeek
     *
     * @var string
     */
    public $progressMergePeriod;
    protected $_name = [
        'krId'                    => 'krId',
        'mergeIntoLatestProgress' => 'mergeIntoLatestProgress',
        'objectiveId'             => 'objectiveId',
        'plainText'               => 'plainText',
        'progress'                => 'progress',
        'progressMergePeriod'     => 'progressMergePeriod',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->krId) {
            $res['krId'] = $this->krId;
        }
        if (null !== $this->mergeIntoLatestProgress) {
            $res['mergeIntoLatestProgress'] = $this->mergeIntoLatestProgress;
        }
        if (null !== $this->objectiveId) {
            $res['objectiveId'] = $this->objectiveId;
        }
        if (null !== $this->plainText) {
            $res['plainText'] = $this->plainText;
        }
        if (null !== $this->progress) {
            $res['progress'] = $this->progress;
        }
        if (null !== $this->progressMergePeriod) {
            $res['progressMergePeriod'] = $this->progressMergePeriod;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AgoalCreateProgressRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['krId'])) {
            $model->krId = $map['krId'];
        }
        if (isset($map['mergeIntoLatestProgress'])) {
            $model->mergeIntoLatestProgress = $map['mergeIntoLatestProgress'];
        }
        if (isset($map['objectiveId'])) {
            $model->objectiveId = $map['objectiveId'];
        }
        if (isset($map['plainText'])) {
            $model->plainText = $map['plainText'];
        }
        if (isset($map['progress'])) {
            $model->progress = $map['progress'];
        }
        if (isset($map['progressMergePeriod'])) {
            $model->progressMergePeriod = $map['progressMergePeriod'];
        }

        return $model;
    }
}
