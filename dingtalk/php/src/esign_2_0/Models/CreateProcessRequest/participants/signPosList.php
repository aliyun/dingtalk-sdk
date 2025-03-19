<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CreateProcessRequest\participants;

use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CreateProcessRequest\participants\signPosList\signDate;
use AlibabaCloud\Tea\Model;

class signPosList extends Model
{
    /**
     * @var string
     */
    public $fileId;

    /**
     * @var bool
     */
    public $isCrossPage;

    /**
     * @var bool
     */
    public $needSignDate;

    /**
     * @var string
     */
    public $page;

    /**
     * @var signDate
     */
    public $signDate;

    /**
     * @var string
     */
    public $signRequirement;

    /**
     * @var float
     */
    public $x;

    /**
     * @var float
     */
    public $y;
    protected $_name = [
        'fileId' => 'fileId',
        'isCrossPage' => 'isCrossPage',
        'needSignDate' => 'needSignDate',
        'page' => 'page',
        'signDate' => 'signDate',
        'signRequirement' => 'signRequirement',
        'x' => 'x',
        'y' => 'y',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->isCrossPage) {
            $res['isCrossPage'] = $this->isCrossPage;
        }
        if (null !== $this->needSignDate) {
            $res['needSignDate'] = $this->needSignDate;
        }
        if (null !== $this->page) {
            $res['page'] = $this->page;
        }
        if (null !== $this->signDate) {
            $res['signDate'] = null !== $this->signDate ? $this->signDate->toMap() : null;
        }
        if (null !== $this->signRequirement) {
            $res['signRequirement'] = $this->signRequirement;
        }
        if (null !== $this->x) {
            $res['x'] = $this->x;
        }
        if (null !== $this->y) {
            $res['y'] = $this->y;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signPosList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['isCrossPage'])) {
            $model->isCrossPage = $map['isCrossPage'];
        }
        if (isset($map['needSignDate'])) {
            $model->needSignDate = $map['needSignDate'];
        }
        if (isset($map['page'])) {
            $model->page = $map['page'];
        }
        if (isset($map['signDate'])) {
            $model->signDate = signDate::fromMap($map['signDate']);
        }
        if (isset($map['signRequirement'])) {
            $model->signRequirement = $map['signRequirement'];
        }
        if (isset($map['x'])) {
            $model->x = $map['x'];
        }
        if (isset($map['y'])) {
            $model->y = $map['y'];
        }

        return $model;
    }
}
