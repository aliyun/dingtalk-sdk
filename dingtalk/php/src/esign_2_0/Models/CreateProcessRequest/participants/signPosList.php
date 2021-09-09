<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CreateProcessRequest\participants;

use AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models\CreateProcessRequest\participants\signPosList\signDate;
use AlibabaCloud\Tea\Model;

class signPosList extends Model
{
    /**
     * @description 文件id
     *
     * @var string
     */
    public $fileId;

    /**
     * @description 是否为骑缝章
     *
     * @var bool
     */
    public $isCrossPage;

    /**
     * @description 是否需要显示签署时间
     *
     * @var bool
     */
    public $needSignDate;

    /**
     * @description 签署区页码
     *
     * @var string
     */
    public $page;

    /**
     * @var signDate
     */
    public $signDate;

    /**
     * @description 签署要求,1-企业章 2-经办人
     *
     * @var string
     */
    public $signRequirement;

    /**
     * @description 签署区x坐标
     *
     * @var float
     */
    public $x;

    /**
     * @description 签署区y坐标
     *
     * @var float
     */
    public $y;
    protected $_name = [
        'fileId'          => 'fileId',
        'isCrossPage'     => 'isCrossPage',
        'needSignDate'    => 'needSignDate',
        'page'            => 'page',
        'signDate'        => 'signDate',
        'signRequirement' => 'signRequirement',
        'x'               => 'x',
        'y'               => 'y',
    ];

    public function validate()
    {
    }

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
